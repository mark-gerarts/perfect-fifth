module P5Reference.Structure.Preload

open P5.Core
open P5.Color
open P5.Image

// When creating a preloaded sketch, the preload function returns some preload
// state. This state is received in the setup function, which in turn returns
// the actual world state.
// In the case of `display`, `setup` and `draw` are combined in a single
// function, which then receives the preload state.
let preload p5 = loadImage p5 "assets/laDefense.png"

let draw p5 (img: P5Image) =
    img.loadPixels ()
    let centerPixel = img.getPixel (img.width / 2 |> float) (img.height / 2 |> float)
    background p5 (Values centerPixel)
    imageWithSize p5 img 25 25 50 50

// `simulate` and `play` also have preload alternatives.
let run node = displayWithPreload node preload draw
