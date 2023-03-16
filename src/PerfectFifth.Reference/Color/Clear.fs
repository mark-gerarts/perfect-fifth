module P5Reference.Color.Clear

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Events

let update _ = id

let draw p5 _ =
    circle p5 (mouseX p5) (mouseY p5) 20
    describe p5 "small white ellipses are continually drawn at mouse’s x and y coordinates."

let eventHandler p5 event state =
    match event with
    | MousePressed _ ->
        clear p5
        background p5 (Grayscale 128)
        describe p5 "canvas is cleared, small white ellipse is drawn at mouse X and mouse Y"
    | _ -> ()

    state

let run node =
    play node noSetup update draw eventHandler
