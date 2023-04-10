module P5Reference.Image.Set0

open P5.Core
open P5.Color
open P5.Image

let draw p5 =
    let black = Grayscale 0
    setPixel p5 30 20 black
    setPixel p5 85 20 black
    setPixel p5 85 75 black
    setPixel p5 30 75 black
    updatePixels p5

let run node = display node draw
