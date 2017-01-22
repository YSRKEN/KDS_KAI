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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KDS_KAI {
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void CalcButton_Click(object sender, RoutedEventArgs e) {

		}

		private void AttackKammusuButton_Click(object sender, RoutedEventArgs e) {
			var ksw = new KammusuSelectWindow(BattleSide.Attack);
			ksw.Show();
		}
		private void AttackWeapon1Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Attack, 0);
			wsw.Show();
		}
		private void AttackWeapon2Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Attack, 1);
			wsw.Show();
		}
		private void AttackWeapon3Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Attack, 2);
			wsw.Show();
		}
		private void AttackWeapon4Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Attack, 3);
			wsw.Show();
		}
		private void AttackWeapon5Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Attack, 4);
			wsw.Show();
		}

		private void DefenseKammusuButton_Click(object sender, RoutedEventArgs e) {
			var ksw = new KammusuSelectWindow(BattleSide.Defense);
			ksw.Show();
		}
		private void DefenseWeapon1Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Defense, 0);
			wsw.Show();
		}
		private void DefenseWeapon2Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Defense, 1);
			wsw.Show();
		}
		private void DefenseWeapon3Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Defense, 2);
			wsw.Show();
		}
		private void DefenseWeapon4Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Defense, 3);
			wsw.Show();
		}
		private void DefenseWeapon5Button_Click(object sender, RoutedEventArgs e) {
			var wsw = new WeaponSelectWindow(BattleSide.Defense, 4);
			wsw.Show();
		}
	}
}
