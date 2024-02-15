using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MordhauCheat_2._0
{
    public partial class Menu : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        private readonly Mem mem = new Mem();
        public Menu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int pID = mem.GetProcIdFromName("Mordhau-Win64-Shipping");
            if (pID != 0)
            {
                mem.OpenProcess(pID);
                pIDLabel.Text = "MORDHAU PID: " + pID.ToString();


            }
            else 
            {
                DialogResult res = MessageBox.Show("Mordhau must be running", "Silly window for silly people", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    Application.Exit();
                } 
             }   
        }

        bool skip = false;
        float defaultfov = 0;

        private void Global_Tick(object sender, EventArgs e)
        {
            if (mem.ReadByte(Offsets.IsAlive) != 0)
            {
                if (skip == false)
                {
                    float defaultfov = mem.ReadFloat(Offsets.DefaultFOV);
                    skip = true;
                }

                // if (mem.ReadMemory<byte>(Offsets.CheckIfSwing) == 1)
                // {
                //     mem.WriteMemory(Offsets.UMordhauMotion + ",B48", "float", "5");
                // }

                if (mem.ReadFloat(Offsets.AfkTimer, "") > 170 & (Antiafkbutton.Checked))
                {
                    mem.WriteMemory(Offsets.AfkTimer, "float", "0");
                }
                    
                afklabel.Text = mem.ReadFloat(Offsets.AfkTimer, "").ToString();
                if (mem.ReadByte(Offsets.nextbox, "") == 0) { resuplabel.Text = "Yes"; } else { resuplabel.Text = "No"; }
                mem.WriteMemory(Offsets.DodgeCooldown, "float", (DodgeCooldownBar.Value * 0.150).ToString());
                mem.WriteMemory(Offsets.DodgeDuration, "float", (DodgeDurationBar.Value * 0.375).ToString());
                alivelabel.Text = "Alive";
                if (dodgebutton.Checked) 
                {
                    dodgebutton.Enabled = true;
                    mem.WriteMemory(Offsets.CanDodge, "byte", "1");
                    dodgecooldown.Text = mem.ReadFloat(Offsets.DodgeCooldown, "").ToString();
                    dodgetime.Text = mem.ReadFloat(Offsets.DodgeDuration, "").ToString();
                }
                else
                {
                    mem.WriteMemory(Offsets.CanDodge, "byte", "0");
                }
                if (Turncapbutton.Checked)
                {
                    turncapxtrack.Enabled = true;
                    turncapytrack.Enabled = true;
                    label9.Text = turncapxtrack.Value.ToString();
                    label8.Text = turncapytrack.Value.ToString();


                    if (mem.ReadFloat(Offsets.turncapx) != -1)
                    {
                        mem.WriteMemory(Offsets.turncapy, "float", turncapytrack.Value.ToString());
                        mem.WriteMemory(Offsets.turncapx, "float", turncapxtrack.Value.ToString());
                    }
                }

                if (FOVcheck.Checked)
                {
                    FOVtrackbar.Enabled = true;
                    metroLabel2.Text = FOVtrackbar.Value.ToString();
                    mem.WriteMemory(Offsets.RealFOV, "float", FOVtrackbar.Value.ToString());
                }
                else
                {
                    FOVtrackbar.Enabled = false;
                    mem.WriteMemory(Offsets.RealFOV, "float", defaultfov.ToString());
                    metroLabel2.Text = mem.ReadFloat(Offsets.DefaultFOV).ToString();
                }
                if (teamespbox.Checked)
                {
                    teamespbox.Enabled = true;
                    mem.WriteMemory(Offsets.teamesp, "byte", "1");
                }
                else
                {
                    mem.WriteMemory(Offsets.teamesp, "byte", "0");
                }
                if (nosmoke.Checked)
                {
                    nosmoke.Enabled = true;
                    mem.WriteMemory(Offsets.smokesmooth, "float", "0");
                    mem.WriteMemory(Offsets.smokesmoothfield, "float", "0");
                }
                else {}
                if (ezparry.Checked)
                {
                    nosmoke.Enabled = true;
                    mem.WriteMemory(Offsets.easyparry, "float", "0");
                }
            }

            else { alivelabel.Text = "Dead!"; }

        }
    }
}
