module P5Reference.Image.Image3

open P5.Core
open P5.Image
open P5.Color
open P5.Environment

let preload p5 = loadImage p5 "assets/moonwalk.jpg"

let draw p5 (img: P5Image) =
    background p5 (Name "green")

    let width = width p5 |> float
    let height = height p5 |> float

    let options =
        { imageOptions 0 0 width height 0 0 with
            sWidth = Some(float img.width)
            sHeight = Some(float img.height)
            fit = Contain
            xAlign = ImageAlignXLeft }

    imageWithOptions p5 img options

let run node = displayWithPreload node preload draw
