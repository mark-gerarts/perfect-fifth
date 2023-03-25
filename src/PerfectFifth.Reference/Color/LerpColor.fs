module P5Reference.Color.LerpColor

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    colorMode p5 ModeRGB
    stroke p5 (Grayscale 255)
    background p5 (Grayscale 51)
    let src = color p5 (RGB(218, 165, 32))
    let dst = color p5 (RGB(72, 61, 139))
    colorMode p5 ModeRGB
    let interA = lerpColor p5 src dst 0.33
    let interB = lerpColor p5 src dst 0.66
    fill p5 (P5Color src)
    rect p5 10 20 20 60
    fill p5 (P5Color interA)
    rect p5 30 20 20 60
    fill p5 (P5Color interB)
    rect p5 50 20 20 60
    fill p5 (P5Color dst)
    rect p5 70 20 20 60

let run node = display node draw
