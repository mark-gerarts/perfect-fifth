module P5Reference.Image.Get0

open P5.Core
open P5.Environment
open P5.Image

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 img =
    image p5 img 0 0
    let c = getImage p5
    image p5 c (width p5 / 2 |> float) 0

let run node = displayWithPreload node preload draw
