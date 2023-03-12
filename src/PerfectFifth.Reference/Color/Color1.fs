module P5Reference.Color.Color1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    let c = color p5 (RGB(255, 204, 0))
    fill p5 (P5Color c)
    noStroke p5
    circle p5 25 25 80

    // Using only one value generates a grayscale value.
    // Also, there is no need for a P5Color object for most color functions.
    fill p5 (Grayscale 65)
    circle p5 75 75 80
    describe p5 "Yellow ellipse in top left of canvas, black ellipse in bottom right, both 80×80."

let run node = display node draw
