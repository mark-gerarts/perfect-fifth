module P5Reference.Image.CreateImage0

open P5.Core
open P5.Image
open P5.Color

let draw p5 =
    let img = createImage p5 66 66
    img.loadPixels ()

    for i in seq { 0 .. (img.width - 1) } do
        for j in seq { 0 .. (img.height - 1) } do
            img.setPixel (float i) (float j) (color p5 (RGB(0, 90, 102)))

    img.updatePixels ()
    image p5 img 17 17

let run node = display node draw
