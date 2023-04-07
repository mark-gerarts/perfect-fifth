module P5Reference.Image.SaveFrames

open P5.Core
open P5.Color
open P5.Events
open P5.Image

let draw p5 _ = mouseX p5 |> Grayscale |> background p5

let onMousePressed p5 _ =
    let framesCallback (frames: FrameObject array) = console.log frames

    saveFramesWithCallback p5 "out" "png" 1 25 framesCallback

let subscriptions = [ OnMousePressed(Effect onMousePressed) ]

let run node =
    play node noSetup noUpdate draw subscriptions
