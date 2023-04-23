module P5Reference.Typography.TextStyle

open P5.Core
open P5.Shape
open P5.Typography

let draw p5 =
    strokeWeight p5 0
    setTextSize p5 12

    setTextStyle p5 Normal
    text p5 "Font Style Normal" 10 15
    setTextStyle p5 Italic
    text p5 "Font Style Italic" 10 40
    setTextStyle p5 Bold
    text p5 "Font Style Bold" 10 65
    setTextStyle p5 BoldItalic
    text p5 "Font Style Bold Italic" 10 90

let run node = display node draw
