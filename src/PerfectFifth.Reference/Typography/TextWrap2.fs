module P5Reference.Typography.TextWrap2

open P5.Core
open P5.Typography

let draw p5 =
    setTextSize p5 20
    textWrap p5 Char
    textBounded p5 "祝你有美好的一天" 0 10 100 100

let run node = display node draw
