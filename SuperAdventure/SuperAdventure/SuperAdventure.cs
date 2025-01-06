using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Edgine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;//创建一个类级的变量，私有，且名字为_player
        public SuperAdventure()     //是构造函数吗？ 和“namespace ”同名
        {
            InitializeComponent();
            Location location = new Location(1,"Home","This is your huose.");
           
            
           
            _player = new Player(10, 10, 20, 0, 1);


            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

        }
        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
