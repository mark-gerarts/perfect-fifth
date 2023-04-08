module P5Reference.Image.P5ImagePlay

open P5.Core
open P5.Color
open P5.Image

let preload p5 =
    loadImage p5 "assets/nancy-liang-wind-loop-forever.gif"

let setup _ = id

let draw p5 (gif: P5Image) =
    background p5 (Grayscale 255)
    image p5 gif 0 0

let onMousePressed _ _ (gif: P5Image) =
    gif.pause ()
    gif

let onMouseReleased _ _ (gif: P5Image) =
    gif.play ()
    gif

let subscriptions =
    [ OnMousePressed(Update onMousePressed)
      OnMouseReleased(Update onMouseReleased) ]

let run node =
    playWithPreload node preload setup noUpdate draw subscriptions
