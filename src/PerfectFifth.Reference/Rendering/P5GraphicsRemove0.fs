module P5Reference.Rendering.P5GraphicsRemove0

open P5.Core
open P5.Color
open P5.Rendering
open P5.Image

let draw p5 =
    let bg = createCanvasAndReturn p5 100 100
    background bg (Grayscale 0)
    image p5 bg 0 0
    bg.remove ()

let run node = display node draw
