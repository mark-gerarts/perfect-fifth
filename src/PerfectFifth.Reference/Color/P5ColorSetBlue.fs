module P5Reference.Color.P5ColorSetBlue

open P5.Core
open P5.Color

let setup (p5: P5) = color p5 (RGB(100, 50, 150))

let update p5 (color: P5Color) =
    let t = (millis p5 |> float) / 1000.0
    color.setBlue (128.0 + 128.0 * (sin t))
    color

let draw p5 color = background p5 (P5Color color)

let run node = simulate node setup update draw
