module P5Reference.Typography.Text1

open P5.Core
open P5.Color
open P5.Typography

let draw p5 =
    let s = "The quick brown fox jumped over the lazy dog."
    fill p5 (Grayscale 50)
    textBounded p5 s 10 10 70 80 // Text wraps within text box

let run node = display node draw
