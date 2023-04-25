module P5Reference.Typography.Text0

open P5.Core
open P5.Color
open P5.Typography

let draw p5 =
    setTextSize p5 32
    text p5 "word" 10 30
    fill p5 (RGB(0, 102, 153))
    text p5 "word" 10 60
    fill p5 (RGBA(0, 102, 153, 51))
    text p5 "word" 10 90

let run node = display node draw
