module P5Reference.Image.P5ImageDelay

open P5.Core
open P5.Image
open P5.Environment
open P5.Color

let preload p5 =
    let fast = loadImage p5 "assets/arnott-wallace-eye-loop-forever.gif"
    let slow = loadImage p5 "assets/arnott-wallace-eye-loop-forever.gif"
    (fast, slow)

let setup p5 (fast: P5Image, slow: P5Image) =
    fast.resize (width p5 / 2 |> float) (height p5 / 2 |> float)
    slow.resize (width p5 / 2 |> float) (height p5 / 2 |> float)

    //Change the delay here
    fast.delay 10
    slow.delay 100

    (fast, slow)

let draw p5 (fast: P5Image, slow: P5Image) =
    background p5 (Grayscale 255)
    image p5 fast 0 0
    image p5 slow (width p5 / 2 |> float) 0

let run node =
    simulateWithPreload node preload setup noUpdate draw
