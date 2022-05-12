module MainForm

open System
open System.Windows.Forms
open System.Drawing

type MainForm() as this =
    inherit Form()    
    do this.ClientSize <- Size(400, 300)
    do this.MaximizeBox <- false
    do this.FormBorderStyle <- FormBorderStyle.FixedSingle
    do this.CreateControl()

    member private this.CreateControl () =
        base.AutoScaleMode <- AutoScaleMode.Font
        base.ClientSize <- System.Drawing.Size(800, 450)
        base.Text <- "F# Form1"

        let mutable btn = new Button()
        btn.Text <- "Hello F# WinForms"
        btn.Location <- new Point(10, 10)
        btn.Size <- Size(140, 30)
        btn.Click.Add(fun evtArgs -> MessageBox.Show("Hello F# MessageBox") |> ignore)
        this.Controls.Add(btn)

        let mutable txt = new TextBox()
        txt.Text <- "Hello F# WinForms"
        txt.Location <- new Point(10, 50)
        txt.Size <- Size(140, 30)
        this.Controls.Add(txt)

        let mutable rdbox = new RadioButton()
        rdbox.Text <- "Hello F# WinForms"
        rdbox.Location <- new Point(10, 100)
        rdbox.Size <- Size(140, 30)
        this.Controls.Add(rdbox)

        let mutable chkbox = new CheckBox()
        chkbox.Text <- "Hello F# WinForms"
        chkbox.Location <- new Point(10, 150)
        chkbox.Size <- Size(140, 30)
        this.Controls.Add(chkbox)

        let mutable mtxt = new TextBox()
        mtxt.AcceptsReturn <- true
        mtxt.AcceptsTab <-  true
        // mtxt.Dock <-  System.Windows.Forms.DockStyle.Fill
        mtxt.Multiline <-  true;
        mtxt.ScrollBars <-  System.Windows.Forms.ScrollBars.Vertical
        mtxt.Location <- new Point(200, 10)
        mtxt.Size <- Size(200, 200)
        this.Controls.Add(mtxt)
        ()

    override this.OnFormClosing args = base.OnFormClosing args
    override this.OnShown args = base.OnShown args
        


