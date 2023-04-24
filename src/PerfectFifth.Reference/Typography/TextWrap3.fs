module P5Reference.Typography.TextWrap3

open P5.Core
open P5.Color
open P5.Shape
open P5.Typography

let draw p5 =
    let scream = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
    setTextSize p5 20
    textWrap p5 Word
    textBounded p5 scream 0 0 100 100
    fill p5 (GrayscaleA(0, 75))
    textBounded p5 scream 0 20 100 100
    fill p5 (GrayscaleA(0, 50))
    textBounded p5 scream 0 40 100 100
    fill p5 (GrayscaleA(0, 25))
    textBounded p5 scream 0 60 100 100
    strokeWeight p5 2
    ellipseMode p5 DrawMode.Center
    fill p5 (Grayscale 255)
    ellipse p5 15 50 15 15
    fill p5 (Grayscale 0)
    ellipse p5 11 47 1 1
    ellipse p5 19 47 1 1
    ellipse p5 15 52 5 5
    line p5 15 60 15 70
    line p5 15 65 5 55
    line p5 15 65 25 55
    line p5 15 70 10 80
    line p5 15 70 20 80

let run node = display node draw
