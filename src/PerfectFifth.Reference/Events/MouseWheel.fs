module P5Reference.Events.MouseWheel

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open Browser.Types

let setup _ = 25.0

let draw p5 pos =
    background p5 (RGB(237, 34, 93))
    fill p5 (Grayscale 0)
    rect p5 25 pos 50 50

let onMouseWheel p5 (event: WheelEvent) pos =
    print p5 (string event.deltaY)
    pos + (event.deltaY / 100.0)

let subscriptions = [ OnMouseWheel(Update onMouseWheel) ]

let run node =
    play node setup noUpdate draw subscriptions
