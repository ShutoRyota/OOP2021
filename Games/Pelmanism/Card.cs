﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pelmanism {
    //カードクラス
    class Card : Button{

        //カードの横幅と高さ
        private const int SizeW = 50, SizeH = 70;
        //カードの絵柄
        public Image Picture { get; set; }
        //カードの状態 true:表 false:裏
        public bool State { get; set; }
        //カード表面の色
        public Color OpenColor { get; } = Color.White;
        //カード裏面の色
        public Color CloseColor { get; } = Color.LightGreen;

        public Card(Image picture) {
            Picture = picture;
            State = false;
            Size = new Size(SizeW,SizeH);
            BackColor = CloseColor;
            Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            Enabled = false;
        }

        //カードをオープン
        public void Open() {
            State = true; //表
            BackColor = OpenColor;
            Image = Picture;
            Enabled = false; //選択不可
        }

        //カードをクローズ
        public void Close() {
            State = false; //裏
            BackColor = CloseColor;
            Image = null;
            Enabled = true; //選択可
        }

        //カードをひっくり返す
        public void Turn() {
            if (State) {
                Close();
            }else{
                Open();
            }
        }
    }
}
