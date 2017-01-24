using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static KDS_KAI.Constant;

namespace KDS_KAI {
	/// <summary>
	/// WeaponSelectWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class WeaponSelectWindow : Window {
		// 選択する装備を付ける艦が攻方か受方かを記憶しておく
		BattleSide battleSide;
		// 選択する装備が何番目のスロットかを記憶しておく
		int SlotIndex;
		// コンストラクタ
		public WeaponSelectWindow(BattleSide bs, int si) {
			InitializeComponent();
			// 引数を受け取り、画面に反映する
			battleSide = bs;
			SlotIndex = si;
			this.SelectInfoTextBlock.Text = "設定対象：" + (battleSide == BattleSide.Attack ? "攻撃艦" : "防御艦") + " 第" + (SlotIndex + 1).ToString() + "スロット";
			// コンボボックスの中身を動的に初期化する
			// 改修度
			for(int level = 0; level < WeaponLevelMax; ++level) {
				WeaponLevelComboBox.Items.Add("★" + level.ToString());
			}
			WeaponLevelComboBox.Items.Add("★MAX");
			WeaponLevelComboBox.SelectedIndex = 0;
		}
	}
}
