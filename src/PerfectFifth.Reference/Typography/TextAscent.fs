module P5Reference.Typography.TextAscent

open P5.Core
open P5.Environment
open P5.Shape
open P5.Typography

let draw p5 =
    let height = height p5 |> float
    let width = width p5 |> float
    let baseHeight = height * 0.75
    let scalar = 0.8 // Different for each font

    setTextSize p5 32 // Set initial text size
    let asc = textAscent p5 * scalar // Calc ascent
    line p5 0 (baseHeight - asc) width (baseHeight - asc)
    text p5 "dp" 0 baseHeight // Draw text on baseline

    setTextSize p5 64 // Increase text size
    let asc' = textAscent p5 * scalar // Recalc ascent
    line p5 40 (baseHeight - asc') width (baseHeight - asc')
    text p5 "dp" 40 baseHeight // Draw text on baseline

let run node = display node draw
