using App.WinForm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App.WinForm.Forms
    {
    public partial class MainForm : Form
    {
        private Button _activeButton;

        private readonly Color NavNormalBlack = Color.FromArgb(244, 244, 246);
        private readonly Color NavActiveBlack = Color.FromArgb(153, 153, 161);

        private readonly Color NavNormalFore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;

        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public MainForm()
        {
            InitializeComponent();

            
        }
        private void SetActiveNavButton(Button btn)
        {
            if (btn == null) return;


            if (_activeButton != null)
            {
                _activeButton.BackColor = NavNormalBlack;
                _activeButton.ForeColor = NavNormalFore;
                _activeButton.Font = new Font(_activeButton.Font, FontStyle.Regular);

            }
            //set
            _activeButton = btn;
            _activeButton.BackColor = NavNormalBlack;
            _activeButton.ForeColor = NavNormalFore;
            _activeButton.Font = new Font(_activeButton.Font, FontStyle.Bold);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            //SetActiveNavButton(btndashboard);
            //pnlContainer.Controls.Clear();
            //pnlContainer.Controls.Add(new DashBoardView());
            ShowView(() => new DashBoardView());

        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            //SetActiveNavButton(btnproducts);
            //pnlContainer.Controls.Clear();
            //pnlContainer.Controls.Add(new productview());
            ShowView(() => new productview());
        }
        private void ShowView<T>(Func<T> factory)where T : UserControl
        {
            var key = typeof(T);
            if (!_views .TryGetValue(key,out var view))
            {
               
                view = factory();
                _views[key] = view;
                view.Dock = DockStyle.Fill;
            }
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(view);



        }
    }
}
