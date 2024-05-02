using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using epex.mordhau.recode;
using Memory;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
namespace MordhauCheat_2._0
{

    public partial class Menu : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Int32 vKey);

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
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        bool skip = false;
        float defaultfov = 0;

        float WorldDistance(Vector3 Player, Vector3 Enemy)
        {
            return (float)Math.Sqrt(Math.Pow(Player.X - Enemy.X, 2.0) + Math.Pow(Player.Y - Enemy.Y, 2.0) + Math.Pow(Player.Z - Enemy.Z, 2.0));
        }

        private void Global_Tick(object sender, EventArgs e)
        {
            if (mem.ReadByte(Offsets.IsAlive) != 0)
            {
                if (skip == false)
                {
                    float defaultfov = mem.ReadFloat(Offsets.DefaultFOV);
                    skip = true;
                }

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
                if (nosmoke.Checked)
                {
                    nosmoke.Enabled = true;
                    mem.WriteMemory(Offsets.smokesmooth, "float", "0");
                    mem.WriteMemory(Offsets.smokesmoothfield, "float", "0");
                }

                if (ezparry.Checked)
                {
                    nosmoke.Enabled = true;
                    mem.WriteMemory(Offsets.easyparry, "float", "0");
                    mem.WriteMemory(Offsets.EasyParryDuration, "float", "1000");
                }  

                if (lateriposttoggle.Checked)
                {
                    lateripostelabel.Text = "0." + lateripostbar.Value.ToString();
                    lateripostbar.Enabled = true;
                    mem.WriteMemory(Offsets.RiposteWindowBase, "float", "0." + lateripostbar.Value.ToString());
                }
                else
                {
                    lateripostbar.Enabled = false;
                    mem.WriteMemory(Offsets.RiposteWindowBase, "float", "0.1");
                }

                Debug.WriteLine("Team 1 - R: " + mem.ReadFloat(Offsets.folorteamA_R) + "G: " + mem.ReadFloat(Offsets.folorteamA_G) + "B " + mem.ReadFloat(Offsets.folorteamA_B));
                Debug.WriteLine("Team 1 - R: " + team1R.Value + "G: " + team1G.Value + "B " + team1B.Value);
                Debug.WriteLine("-------");
                Debug.WriteLine("Team 2 - R: " + mem.ReadFloat(Offsets.folorteamB_R) + "G: " + mem.ReadFloat(Offsets.folorteamB_G) + "B " + mem.ReadFloat(Offsets.folorteamB_B));
                Debug.WriteLine("Team 2 - R: " + team2R.Value + "G: " + team2G.Value + "B " + team2B.Value);
                Debug.WriteLine("-----------------");
               
                if (teamcolors.Checked)
                    {
                       float MapToFloat(int number)
                           {
                               return (float)number / 255.0F;
                           }

                        //mem.WriteMemory(Offsets.forcecoloroverride, "byte", "1");

                        mem.WriteMemory(Offsets.folorteamA_R , "float", MapToFloat(Convert.ToInt32(team1R.Value)).ToString());
                        mem.WriteMemory(Offsets.folorteamA_G , "float", MapToFloat(Convert.ToInt32(team1G.Value)).ToString());
                        mem.WriteMemory(Offsets.folorteamA_B , "float", MapToFloat(Convert.ToInt32(team1B.Value)).ToString());
                        team1label.ForeColor = Color.FromArgb(255, Convert.ToInt32(team1R.Value), Convert.ToInt32(team1G.Value), Convert.ToInt32(team1B.Value));

                        mem.WriteMemory(Offsets.folorteamB_R , "float", MapToFloat(Convert.ToInt32(team2R.Value)).ToString());
                        mem.WriteMemory(Offsets.folorteamB_G , "float", MapToFloat(Convert.ToInt32(team2G.Value)).ToString());
                        mem.WriteMemory(Offsets.folorteamB_B , "float", MapToFloat(Convert.ToInt32(team2B.Value)).ToString());
                        team2label.ForeColor = Color.FromArgb(0, Convert.ToInt32(team2R.Value), Convert.ToInt32(team2G.Value), Convert.ToInt32(team2B.Value));
                    }
                else { mem.WriteMemory(Offsets.forcecoloroverride, "byte", "0"); }

                if ( breakanims.Checked )
                    {
                        int keybind = (int)breakanimkeybind.Value;
                        short keyStatus = GetAsyncKeyState((int)keybind);
                    if ( keyStatus < 0 ) { mem.WriteMemory(Offsets.EndTime , "float" , "0"); breakanimlabel.Text = "HELD"; breakanimlabel.ForeColor = Color.GreenYellow; }
                    else
                        {
                        breakanimlabel.Text = "UNHELD";
                        breakanimlabel.ForeColor = Color.PaleVioletRed;
                        }
                    }
                else { breakanimlabel.ForeColor = Color.PaleVioletRed; breakanimlabel.Text = "OFF";}

                if (parrycooldown.Checked)
                {
                    parrytrack.Enabled = true;
                    mem.WriteMemory(Offsets.ParryRecoveryTime, "float", "0." + parrytrack.Value.ToString());
                    parrytracklabel.Text = "0." + parrytrack.Value.ToString();
                }
                else
                {
                    parrytrack.Enabled = false;
                    parrytracklabel.Text = "0";
                    mem.WriteMemory(Offsets.ParryRecoveryTime, "float", "0.675");
                }
            }

            else { alivelabel.Text = "Dead!"; }

        }

        private Overlay overlay = new Overlay();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.overlay.Show();
                return;
            }
            this.overlay.Hide();
        }

        private void Autoblock_Tick(object sender, EventArgs e)
        {
            if (Autoblock.Checked)
                { 
                    int offset = 0;
                    int Playeroffset = this.mem.ReadInt(Offsets.PlayerSizeOffset, "") - 1;
                    string Player = Offsets.Player_Array + ",0";
                    Vector3 PlayerLocation;
                    PlayerLocation.X = mem.ReadFloat(Player + ",280," + Offsets.player_x, "", true);
                    PlayerLocation.Y = mem.ReadFloat(Player + ",280," + Offsets.player_y, "", true);
                    PlayerLocation.Z = mem.ReadFloat(Player + ",280," + Offsets.player_z, "", true);
                    //Debug.WriteLine(PlayerLocation);
                    for (int i = 0; i < Playeroffset; i++)
                    {
                        if (offset == 0)
                        {
                            offset = 8;
                        }
                        else
                        {
                            offset += 8;
                        }
                        string CurrentPlayer = string.Format("{0},{1:X}", Offsets.Player_Array, offset);
                        if (mem.ReadInt(Offsets.GWorld + "120,6B0", "") == 0 || mem.ReadInt(Playeroffset + ",378", "") != mem.ReadInt(Player + ",378", ""))
                        {
                            Vector3 EnemyLocation;
                            EnemyLocation.X = mem.ReadFloat(CurrentPlayer + ",280," + Offsets.player_x, "", true);
                            EnemyLocation.Y = mem.ReadFloat(CurrentPlayer + ",280," + Offsets.player_y, "", true);
                            EnemyLocation.Z = mem.ReadFloat(CurrentPlayer + ",280," + Offsets.player_z, "", true);

                            float distance_from_me = WorldDistance(PlayerLocation, EnemyLocation) / 100F;

                            // Debug.WriteLine("Stab" + mem.ReadFloat(CurrentPlayer + ",280" + Offsets.CheckIfStab));
                    
                            if (distance_from_me < 2F)
                            {
                                if (mem.ReadFloat(CurrentPlayer + ",280" + Offsets.CheckIfSwing) == 55)
                                {
                                    var Time = mem.ReadFloat(CurrentPlayer + ",280" + ",B08" + ",A68") + mem.ReadFloat(CurrentPlayer + ",280" + ",B08" + ",B48") + mem.ReadFloat(CurrentPlayer + ",280" + ",B08" + ",BA0") - mem.ReadFloat(CurrentPlayer + ",280" + ",B08" + ",B74");
                                    Console.WriteLine(Time);
                                    Thread.Sleep(Convert.ToInt32(Time * 1000));
                                    if (mem.ReadFloat(CurrentPlayer + ",280" + ",B08" + ",E0") != 0F
                                    || mem.ReadFloat(CurrentPlayer + ",280" + ",B08" + ",C8") != 0F
                                    || mem.ReadFloat(CurrentPlayer + ",280" + ",B08" + ",CC") != 0F)
                                    { Thread.Sleep(400); break; }
                                    else { mem.WriteMemory(Offsets.wantsblock, "byte", "1"); Thread.Sleep((int)mem.ReadFloat(CurrentPlayer + ",280" + ",B08" + ",AB4") * 1020); break; }
                                }
                            break;
                            }
                        }
                    } 
            }
        }

        private void linkLabel1_LinkClicked( object sender , LinkLabelLinkClickedEventArgs e )
            {
                System.Diagnostics.Process.Start("https://cherrytree.at/misc/vk.htm");
            }
        }
}

