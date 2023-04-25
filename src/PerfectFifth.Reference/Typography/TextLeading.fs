module P5Reference.Typography.TextLeading

open P5.Core
open P5.Typography

let draw p5 =
    let lines = "L1\nL2\nL3" // "\n" is a "new line" character
    setTextSize p5 12

    setTextLeading p5 10
    text p5 lines 10 25

    setTextLeading p5 20
    text p5 lines 40 25

    setTextLeading p5 30
    text p5 lines 70 25

let run node = display node draw
