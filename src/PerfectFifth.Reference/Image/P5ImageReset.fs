module P5Reference.Image.P5ImageReset

open P5.Core
open P5.Image
open P5.Events
open P5.Color

let preload p5 =
    loadImage p5 "assets/arnott-wallace-wink-loop-once.gif"

let draw p5 (gif: P5Image) =
    background p5 (Grayscale 255)
    image p5 gif 0 0

let onMousePressed p5 _ (gif: P5Image) =
    gif.reset ()
    gif

let subscriptions = [ OnMousePressed(Update onMousePressed) ]

let run node =
    playWithPreload node preload noUpdate noUpdate draw subscriptions
