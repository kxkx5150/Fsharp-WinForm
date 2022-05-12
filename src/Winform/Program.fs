open System
open System.Windows.Forms
open System.Threading
open System.IO
open System.Text
open System.Drawing
open MainForm

[<EntryPoint>]
[<STAThread>]
let main argv =
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault false
    use mainwindow = new MainForm()
    Application.Run(mainwindow)
    0
