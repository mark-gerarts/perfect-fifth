module P5Reference.Typography.TextFont1

open P5.Core
open P5.Color
open P5.Shape
open P5.Typography

let preload p5 =
    let fontRegular = loadFont p5 "assets/Regular.otf"
    let fontItalic = loadFont p5 "assets/Italic.ttf"
    let fontBold = loadFont p5 "assets/Bold.ttf"

    (fontRegular, fontItalic, fontBold)

let draw p5 (fontRegular, fontItalic, fontBold) =
    background p5 (Grayscale 210)
    fill p5 (Grayscale 0)
    strokeWeight p5 0
    setTextSize p5 10
    setTextFont p5 fontRegular
    text p5 "Font Style Normal" 10 30
    setTextFont p5 fontItalic
    text p5 "Font Style Italic" 10 50
    setTextFont p5 fontBold
    text p5 "Font Style Bold" 10 70

let run node = displayWithPreload node preload draw
