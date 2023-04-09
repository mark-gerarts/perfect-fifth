module P5Reference.Image.Image2

open P5.Core
open P5.Image

let preload p5 = loadImage p5 "assets/gradient.png"

let draw p5 img =
    image p5 img 0 0

    let options =
        { imageOptions 50 0 40 20 50 50 with
            sWidth = Some 50
            sHeight = Some 50 }

    imageWithOptions p5 img options

let run node = displayWithPreload node preload draw
