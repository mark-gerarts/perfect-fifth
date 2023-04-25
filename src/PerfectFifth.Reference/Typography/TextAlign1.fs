module P5Reference.Typography.TextAlign1

open P5.Core
open P5.Environment
open P5.Shape
open P5.Typography

let draw p5 =
    let width = width p5 |> float

    setTextSize p5 16
    strokeWeight p5 0.5

    line p5 0 12 width 12

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Top }

    textBounded p5 "TOP" 0 12 width 20

    line p5 0 37 width 37

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Center }

    textBounded p5 "CENTER" 0 37 width 20

    line p5 0 62 width 62

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Baseline }

    textBounded p5 "BASELINE" 0 62 width 20

    line p5 0 87 width 87

    setTextAlign
        p5
        { horizontal = HorizontalAlign.Center
          vertical = Bottom }

    textBounded p5 "BOTTOM" 0 87 width 20

let run node = display node draw
