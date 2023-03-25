module P5Reference.Color.Clear

open P5.Core
open P5.Color
open P5.Events
open P5.Shape

let update _ = id

let draw p5 _ = circle p5 (mouseX p5) (mouseY p5) 20

let onMousePressed p5 _ =
    clear p5
    background p5 (Grayscale 128)

let subscriptions = [ OnMousePressed(Effect onMousePressed) ]

let run node =
    play node noSetup update draw subscriptions
