using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Memory;
using MordhauCheat_2._0;
using static System.Net.Mime.MediaTypeNames;

namespace epex.mordhau.recode
{
	// Token: 0x02000002 RID: 2
	public partial class Overlay : Form
	{
		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll")]
		private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x06000004 RID: 4
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000005 RID: 5
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetWindowRect(IntPtr hWnd, out Overlay.ballbox lpRect);

		// Token: 0x06000006 RID: 6
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		// Token: 0x06000007 RID: 7 RVA: 0x000020F3 File Offset: 0x000002F3
		public Overlay()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002A2C File Offset: 0x00000C2C
		private void Overlay_Load(object sender, EventArgs e)
		{
			int procIdFromName = this.m.GetProcIdFromName("Mordhau-Win64-Shipping");
			this.m.OpenProcess(procIdFromName);
			int windowLong = Overlay.GetWindowLong(base.Handle, -20);
			Overlay.SetWindowLong(base.Handle, -20, windowLong | 524288 | 32);
			Overlay.GetWindowRect(this.handle, out this.box);
			base.Size = new Size(this.box.right - this.box.left, this.box.bottom - this.box.top);
			base.Top = this.box.top;
			base.Left = this.box.left;
			Control.CheckForIllegalCrossThreadCalls = false;
			new Thread(new ThreadStart(this.ESP)).Start();
		}

		private void ESP()
		{
			for (;;)
			{
				this.overlay_box.Refresh();
				Thread.Sleep(10);
			}
		
		}

        public static bool WorldToScreen(Vector3 source, Vector3 target, Vector2 viewAngles, float fov, out Vector2 screenPos)
        {
            screenPos = default(Vector2);
            uint screenWidth = 1920;
            uint screenHeight = 1080U;
            float cameraYaw = screenWidth / screenHeight * fov;
            Vector2 angleDifference;
            Overlay.CalcAngle(source, target, out angleDifference);
            Vector2 angleDelta = viewAngles - angleDifference;
            float playerX = (float)Math.Tan((double)angleDelta.X * 0.017453292519943295);
            float playerY = (float)Math.Cos((double)(cameraYaw / 2f) * 0.017453292519943295);
            float playerZ = (float)Math.Sin((double)(cameraYaw / 2f) * 0.017453292519943295);
            float screenPosX = playerX * playerY / playerZ * (screenWidth / 2U);
            float screenPosXFinal = screenWidth / 2U - screenPosX;
        
            float cameraX = (float)Math.Tan((double)angleDelta.Y * 0.017453292519943295);
            float cameraY = (float)Math.Cos((double)(fov / 2f) * 0.017453292519943295);
            float cameraZ = (float)Math.Sin((double)(fov / 2f) * 0.017453292519943295);
            float screenPosZ = cameraX * cameraY / cameraZ * (screenHeight / 2U);
            float screenPosYFinal = screenHeight / 2U - screenPosZ;
            screenPos.X = screenPosXFinal;
            screenPos.Y = screenPosYFinal;
            return true;
        }
        private static bool CalcAngle(Vector3 source, Vector3 target, out Vector2 viewAngles)
        {
            Vector2 vector;
            vector.X = (float)((double)((float)Math.Atan2((double)(target.X - source.X), (double)(target.Y - source.Y))) / 3.1415926535897931 * 180.0);
            vector.Y = (float)(Math.Asin((double)((target.Z - source.Z) / Vector3.Distance(source, target))) * 180.0 / 3.1415926535897931);
            viewAngles = vector;
            return true;
        }

		// Calculate left, up, and forward vectors based on camera orientation
		(Vector3 left, Vector3 up, Vector3 forward) GetCameraOrientationVectors(float cameraPitch, float cameraYaw)
		{
			// Convert pitch and yaw angles from degrees to radians
			float pitchRadians = cameraPitch * (float)Math.PI / 180.0f;
			float yawRadians = cameraYaw * (float)Math.PI / 180.0f;

			// Calculate the direction vector of the camera
			Vector3 direction = new Vector3(
				(float)(Math.Cos(pitchRadians) * Math.Sin(yawRadians)),
				(float)(Math.Sin(pitchRadians)),
				(float)(Math.Cos(pitchRadians) * Math.Cos(yawRadians))
			);

			// Calculate the right vector (perpendicular to the direction vector and pointing to the right)
			Vector3 right = Vector3.Cross(direction, Vector3.UnitY);

			// Calculate the up vector (perpendicular to both the direction and right vectors)
			Vector3 up = Vector3.Cross(right, direction);

			return (right, up, direction);
		}


        private void overlay_box_Paint(object sender, PaintEventArgs e)
		{
			Font font = new Font("Segoe UI", 22f);
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            this.g = e.Graphics;
			string LocalPlayer = Offsets.Player_Array + ",0,280";
			float Fov = m.ReadFloat(Offsets.DefaultFOV, "", true);
			string EnemyPlayer = Offsets.Player_Array + ",8,280";
			float cameraPitch = m.ReadFloat(Offsets.cam_pitch, "", true);
			float cameraYaw = m.ReadFloat(Offsets.cam_yaw);
            float playerX = m.ReadFloat(EnemyPlayer + "," + Offsets.player_x, "", true);
			float playerY = m.ReadFloat(EnemyPlayer + "," + Offsets.player_y, "", true);
			float playerZ = m.ReadFloat(EnemyPlayer + "," + Offsets.player_z, "", true);
            float CameraX = m.ReadFloat(Offsets.cam_x, "", true);
            float CameraY = m.ReadFloat(Offsets.cam_y, "", true);
            float CameraZ = m.ReadFloat(Offsets.cam_z, "", true);
			Vector2 vector;
			vector = default;
           if (WorldToScreen(new Vector3(CameraX, CameraY, CameraZ), new Vector3(playerX, playerY, playerZ), new Vector2( cameraYaw / 2f, -cameraPitch), (uint)Fov, out vector))
            {

				g.DrawString(string.Format("{0} | {1}", vector.X, vector.Y), font, solidBrush, 100f, 100f);
				g.DrawString(string.Format("Camera :{0} | {1} | {2}", CameraX, CameraY, CameraZ), font, solidBrush, 100f, 200f);
				g.DrawString(string.Format("Enemy: {0} | {1} | {2}", playerX, playerY, playerZ), font, solidBrush, 100f, 300f);
				g.DrawString(string.Format("Cam/Y/X: {0} | {1} | Ingame yaw: {2}", cameraPitch, cameraYaw, this.m.ReadFloat(LocalPlayer + ",524", "", true)), font, solidBrush, 100f, 400f);
				g.FillEllipse(solidBrush, new RectangleF(new PointF(vector.X, vector.Y), new SizeF(20f, 20f)));
            
            }
        }

        // Token: 0x04000001 RID: 1
        private Mem m = new Mem();

		// Token: 0x04000002 RID: 2
		private Graphics g;

		// Token: 0x04000003 RID: 3
		private Pen defaultpen = new Pen(Color.Red);

		// Token: 0x04000004 RID: 4
		private Overlay.ballbox box;

		// Token: 0x04000005 RID: 5
		private IntPtr handle = Overlay.FindWindow("UnrealWindow", null);

		// Token: 0x02000003 RID: 3
		public struct ballbox
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}
    }
}
