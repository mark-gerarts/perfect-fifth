module P5Reference.Image.Image4

open P5.Core
open P5.Image
open P5.Environment

let preload p5 = loadImage p5 "assets/laDefense50.png"

let draw p5 (img: P5Image) =
    let width = width p5 |> float
    let height = height p5 |> float

    let options =
        { imageOptions 0 0 width height 0 0 with
            sWidth = Some(float img.width)
            sHeight = Some(float img.height)
            fit = Cover }

    imageWithOptions p5 img options

let run node = displayWithPreload node preload draw
