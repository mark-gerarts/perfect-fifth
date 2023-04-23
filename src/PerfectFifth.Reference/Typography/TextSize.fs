module P5Reference.Typography.TextSize

open P5.Core
open P5.Typography

let draw p5 =
    setTextSize p5 12
    text p5 "Font Size 12" 10 30
    setTextSize p5 14
    text p5 "Font Size 14" 10 60
    setTextSize p5 16
    text p5 "Font Size 16" 10 90

let run node = display node draw
