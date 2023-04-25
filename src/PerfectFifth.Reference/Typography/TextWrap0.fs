module P5Reference.Typography.TextWrap0

open P5.Core
open P5.Typography

let draw p5 =
    setTextSize p5 20
    textWrap p5 Word
    textBounded p5 "Have a wonderful day" 0 10 100 100

let run node = display node draw
