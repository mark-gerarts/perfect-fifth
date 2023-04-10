module P5Reference.Image.P5ImageGetCurrentFrame

open P5.Core
open P5.Image
open P5.Typography

let preload p5 =
    loadImage p5 "assets/arnott-wallace-eye-loop-forever.gif"

let setup _ = id

let draw p5 (gif: P5Image) =
    let frame = gif.getCurrentFrame ()
    image p5 gif 0 0
    text p5 (string frame) 10 90

let run node =
    simulateWithPreload node preload setup noUpdate draw
