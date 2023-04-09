module P5Reference.Image.LoadImage0

open P5.Core
open P5.Image

let preload p5 = loadImage p5 "assets/laDefense.png"

let draw p5 img = image p5 img 0 0

let run node = displayWithPreload node preload draw
