namespace P5

module Typography =

    open Fable.Core
    open P5.Core
    open Fable.Core.JsInterop
    open Util

    [<Emit("$0.textSize()")>]
    let textSize (p5: P5) : int = jsNative

    let getTextSize = textSize

    [<Emit("$0.textSize($1)")>]
    let setTextSize (p5: P5) (size: int) : Unit = jsNative

    type HorizontalAlign =
        | Left
        | Center
        | Right

    type VerticalAlign =
        | Top
        | Bottom
        | Center
        | Baseline

    type TextAlign =
        { horizontal: HorizontalAlign
          vertical: VerticalAlign }

    type private TextAlignRaw =
        { horizontal: string; vertical: string }

    let defaultTextAlign: TextAlign =
        { horizontal = Left
          vertical = Baseline }

    let setTextAlign (p5: P5) (align: TextAlign) : Unit =
        let p5' = unbox<obj> p5

        let rawHorizontalAlign =
            match align.horizontal with
            | Left -> p5'?("LEFT")
            | HorizontalAlign.Center -> p5'?("CENTER")
            | Right -> p5'?("RIGHT")

        let rawVerticalAlign =
            match align.vertical with
            | Top -> p5'?("TOP")
            | Bottom -> p5'?("BOTTOM")
            | VerticalAlign.Center -> p5'?("CENTER")
            | Baseline -> p5'?("BASELINE")

        emitJsExpr (p5, rawHorizontalAlign, rawVerticalAlign) "$0.textAlign($1, $2)"

    [<Emit("$0.textAlign()")>]
    let private getTextAlign_ (p5: P5) : TextAlignRaw = jsNative

    let getTextAlign (p5: P5) : TextAlign =
        let align = getTextAlign_ p5
        let p5' = unbox<obj> p5

        let horizontal =
            if align.horizontal = p5'?("LEFT") then
                Left
            else if align.horizontal = p5'?("CENTER") then
                HorizontalAlign.Center
            else if align.horizontal = p5'?("RIGHT") then
                Right
            else
                failwithUnexpectedValue "textAlign"

        let vertical =
            if align.vertical = p5'?("TOP") then Top
            else if align.vertical = p5'?("BOTTOM") then Bottom
            else if align.vertical = p5'?("CENTER") then Center
            else if align.vertical = p5'?("BASELINE") then Baseline
            else failwithUnexpectedValue "textAlign"

        { horizontal = horizontal
          vertical = vertical }

    [<Emit("$0.text($1, $2, $3)")>]
    let text (p5: P5) (str: string) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.text($1, $2, $3, $4, $5)")>]
    let textBounded (p5: P5) (str: string) (x: float) (y: float) (x1: float) (y2: float) : Unit = jsNative

    [<Emit("$0.textLeading()")>]
    let getTextLeading (p5: P5) : float = jsNative

    let textLeading = getTextLeading

    [<Emit("$0.textLeading($1)")>]
    let setTextLeading (p5: P5) (leading: float) : Unit = jsNative

    type TextStyle =
        | Normal
        | Bold
        | Italic
        | BoldItalic

    let getTextStyle (p5: P5) : TextStyle =
        let p5' = unbox<obj> p5
        let textStyle: string = emitJsExpr (p5) "$0.textStyle()"

        if textStyle = p5'?("NORMAL") then Normal
        else if textStyle = p5'?("BOLD") then Bold
        else if textStyle = p5'?("ITALIC") then Italic
        else if textStyle = p5'?("BOLDITALIC") then BoldItalic
        else failwithUnexpectedValue "textStyle"

    let textStyle = getTextStyle

    let setTextStyle (p5: P5) (style: TextStyle) =
        let p5' = unbox<obj> p5

        let rawStyle =
            match style with
            | Normal -> p5'?("NORMAL")
            | Bold -> p5'?("BOLD")
            | Italic -> p5'?("ITALIC")
            | BoldItalic -> p5'?("BOLDITALIC")

        emitJsExpr (p5', rawStyle) "$0.textStyle($1)"
