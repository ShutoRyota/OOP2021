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
        
        public FormGame() {
            InitializeComponent();
        }

        //カード生成
        //仮引数 cards:カード配列への参照
        private void CreateCards(ref Card[] cards) {
            string[] picture = { "〇", "●", "△", "▲", "□", "■", "◇", "◆", "☆", "★", "※", "×", };

            //カードインスタンス生成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++) {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }

        private void FormGame_Load(object sender, EventArgs e) {
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
                playingCards[i].Click += CardsButtonsClick;
            }

            Controls.AddRange(playingCards);
            ResumeLayout(false);
            labelGuidance.Text = "スタートボタンをクリックしてゲームを開始してください";
        }

        private void CardsButtonsClick(object sender, EventArgs e) {
            throw new NotImplementedException();
        }
    }
}
