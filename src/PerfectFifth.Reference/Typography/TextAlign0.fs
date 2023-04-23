module P5Reference.Typography.TextAlign0

open P5.Core
open P5.Typography

let draw p5 =
    setTextSize p5 16

    setTextAlign
        p5
        { horizontal = Right
          vertical = Baseline }

    text p5 "ABCD" 50 30

    // Or use the defaults.
    setTextAlign p5 { defaultTextAlign with horizontal = HorizontalAlign.Center }
    text p5 "EFGH" 50 50

    setTextAlign
        p5
        { horizontal = Left
          vertical = Baseline }

    text p5 "IJKL" 50 70

let run node = display node draw
