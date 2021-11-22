using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelmanism {
    public partial class FormGame : Form {

        private Card[] playingCards;
        private Player player;
        private int gameSec;
        //制限時間
        private int limit = 5;
        
        public FormGame() {
            InitializeComponent();
        }

        /// <summary>
        /// カード生成
        /// </summary>
        /// <param name="cards">カード配列への参照</param>
        private void CreateCards(ref Card[] cards) {
            Image[] picture = {Image.FromFile(@"pictures/picture1.jpg"), Image.FromFile(@"pictures/picture2.jpg"), Image.FromFile(@"pictures/picture3.jpg"), Image.FromFile(@"pictures/picture4.jpg"),
                Image.FromFile(@"pictures/picture5.jpg"), Image.FromFile(@"pictures/picture6.jpg"), Image.FromFile(@"pictures/picture7.jpg"), Image.FromFile(@"pictures/picture8.jpg"),
                Image.FromFile(@"pictures/picture9.jpg"), Image.FromFile(@"pictures/picture10.jpg"), Image.FromFile(@"pictures/picture11.jpg"), Image.FromFile(@"pictures/picture12.jpg"), };

            //カードインスタンス生成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++) {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }

        private void FormGame_Load(object sender, EventArgs e) {
            //残り時間の設定
            labelSec.Text = labelSec.Text = $"残り{limit}秒";
            timer2.Interval = limit * 1000;

            //カードの生成
            CreateCards(ref playingCards);
            //プレイヤーの生成
            player = new Player();
            //カードをフォームに動的に配置する
            SuspendLayout();

            const int offsetX = 30, offsetY = 50;

            for(int i = 0; i < playingCards.Length; i++) {
                //カードのプロパティを設定する
                playingCards[i].Name = "card" + i;
                int sizeW = playingCards[i].Size.Width;
                int sizeH= playingCards[i].Size.Height;
                playingCards[i].Location = new Point(offsetX + i % 8 * sizeW, offsetY + i / 8 * sizeH);
                playingCards[i].Click += CardButtons_Click;
            }

            Controls.AddRange(playingCards);
            ResumeLayout(false);
            labelGuidance.Text = "スタートボタンをクリックしてゲームを開始してください";
        }

        private void CardButtons_Click(object sender, EventArgs e) {
            //1枚目か２枚目かの判定
            if (player.OpenCounter == 0) {
                //前回のカードが不一致ならカードを伏せる
                int b1 = player.BeforeOpenCardIndex1;
                int b2 = player.BeforeOpenCardIndex2;
                if (b1 != -1 && b2 != -1 && !MatchCard(playingCards, b1, b2)) {
                    playingCards[b1].Close();
                    playingCards[b2].Close();
                }
                //クリックしたボタンのカードから添え字を取得
                int n1 = int.Parse(((Button)sender).Name.Substring(4));
                //１枚目のカードを開く
                playingCards[n1].Open();
                player.NowOpenCardIndex1 = n1;
                labelGuidance.Text = "もう一枚めくってください";
                //2枚目にめくる
            }
            else if (player.OpenCounter == 1) {
                //クリックしたボタンのカードから添え字を取得
                int n2 = int.Parse(((Button)sender).Name.Substring(4));
                //2枚目のカードを開く
                playingCards[n2].Open();
                player.NowOpenCardIndex2 = n2;

                //1枚目と2枚目のカードが一致したかの確認
                if (MatchCard(playingCards, player.NowOpenCardIndex1, player.NowOpenCardIndex2)) {
                    labelGuidance.Text = "カードは一致しました。次のカードをめくってください";
                } else {
                labelGuidance.Text = "カード不一致です。次のカードをめくってください";
                }
                //プレイヤーの情報をリセットする
                player.Reset();

                //全カードをめくったら
                if (AllOpenCard(playingCards)) {
                    labelGuidance.Text = "全部のカードが一致しました。お疲れ様でした。";
                    timer1.Stop();
                    buttonStart.Enabled = true;
                }
            }
            
            
        }

        /// <summary>
        /// カードがすべて開いたかの確認
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        /// <returns>true:すべて表 false:まだ</returns>
        private bool AllOpenCard(Card[] playingCards) {
            foreach (var card in playingCards) {
                if (!card.State) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// カードの一致チェック
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        /// <param name="nowOpenCardIndex1">１枚目のカード</param>
        /// <param name="nowOpenCardIndex2">２枚目のカード</param>
        /// <returns>true:一致 false:不一致</returns>
        private bool MatchCard(Card[] cards, int index1, int index2) {
            if (index1 < 0 || index1 >= cards.Length || index2 < 0 || index2 >= cards.Length)
                return false;

            return cards[index1].Picture.Equals(cards[index2].Picture);
        }

        private void buttonStart_Click(object sender, EventArgs e) {

            //カードシャッフル
            ShuffleCard(playingCards);


            //全部のカードを伏せる
            foreach (var card in playingCards) {
                card.Close();
            }

            buttonStart.Enabled = false;
            gameSec = 0;
            timer1.Start();
            timer2.Start();
            labelGuidance.Text = "クリックしてカードをめくってください";
        }

        /// <summary>
        /// カードを混ぜる
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        private void ShuffleCard(Card[] playingCards) {

            System.Random rand = new System.Random();

            int pt = playingCards.Length;
            foreach(var card in playingCards) {
                pt = --pt;
                var k = rand.Next(pt);
                var tmp = playingCards[k].Picture;
                playingCards[k].Picture = card.Picture;
                card.Picture = tmp;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            gameSec++;
            labelSec.Text = $"残り{(limit - gameSec)}秒";
            
        }

        private void timer2_Tick(object sender, EventArgs e) {            
            labelGuidance.Text = "時間切れです";
            labelSec.Text = "残り0秒";
            timer1.Stop();
        }
    }
}
