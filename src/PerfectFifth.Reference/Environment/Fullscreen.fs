module P5Reference.Environment.Fullscreen

open P5.Core
open P5.Environment
open P5.Events

let update _ = id

let draw _ _ = ()

let handleMousePressed p5 _ =
    let x = mouseX p5
    let y = mouseY p5

    if x > 0 && x < 100 && y > 0 && y < 100 then
        do
            let fs = fullscreen p5
            setFullscreen p5 (not fs)

let subscriptions = [ OnMousePressed(Effect handleMousePressed) ]

let run node =
    play node noSetup update draw subscriptions
