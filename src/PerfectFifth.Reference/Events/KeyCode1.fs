module P5Reference.Events.KeyCode1

open P5.Core
open P5.Color
open P5.Events
open P5.Typography
open P5.Environment

let draw p5 _ = ()

let onKeyPressed p5 _ =
    background p5 (Name "yellow")
    let key = key p5
    let keyCode = (keyCode p5).getKeyCode ()
    let message = sprintf "%s %i" key keyCode

    text p5 message 10 40
    print p5 message

let subscriptions = [ OnKeyPressed(Effect onKeyPressed) ]

let run node =
    play node noSetup noUpdate draw subscriptions
