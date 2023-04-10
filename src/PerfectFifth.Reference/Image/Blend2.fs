module P5Reference.Image.Blend2

open P5.Core
open P5.Rendering
open P5.Image

let preload p5 =
    let img0 = loadImage p5 "assets/rockies.jpg"
    let img1 = loadImage p5 "assets/bricks_third.jpg"
    (img0, img1)

let draw p5 (img0, img1) =
    backgroundImage p5 img0
    image p5 img1 0 0
    blendFrom p5 img1 0 0 33 100 67 0 33 100 Add

let run node = displayWithPreload node preload draw
