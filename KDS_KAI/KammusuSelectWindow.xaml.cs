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
	/// KammusuSelectWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class KammusuSelectWindow : Window {
		// 選択する艦が攻方か受方かを記憶しておく
		BattleSide battleSide;
		// コンストラクタ
		public KammusuSelectWindow(BattleSide bs) {
			InitializeComponent();
			// 引数を受け取り、画面に反映する
			battleSide = bs;
			SelectInfoTextBlock.Text = "設定対象：" + (battleSide == BattleSide.Attack ? "攻撃艦" : "防御艦");
			// コンボボックスの中身を動的に初期化する
			// レベル
			for(int level = 1; level <= KammusuLevelMax; ++level) {
				ShipLevelComboBox.Items.Add(level.ToString());
			}
			ShipLevelComboBox.SelectedIndex = 0;
			
		}
	}
}
