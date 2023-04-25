module P5Reference.Typography.TextWidth

open P5.Core
open P5.Shape
open P5.Typography

let draw p5 =
    setTextSize p5 28

    let aChar = "P"
    let cWidth = textWidth p5 aChar
    text p5 aChar 0 40
    line p5 cWidth 0 cWidth 50

    let aString = "p5.js"
    let sWidth = textWidth p5 aString
    text p5 aString 0 85
    line p5 sWidth 50 sWidth 100

let run node = display node draw
