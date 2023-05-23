namespace P5

module DOM =

    open Fable.Core
    open Browser.Types
    open P5.Core
    open P5.Color

    open Fable.Core.JsInterop

    type PositionType =
        | Static
        | Fixed
        | Relative
        | Sticky
        | Initial
        | Inherit

    type Position = { x: float; y: float }

    type Dimensions = { width: float; y: float }

    let private rawPositionType positionType =
        match positionType with
        | Static -> "static"
        | Fixed -> "fixed"
        | Relative -> "relative"
        | Sticky -> "sticky"
        | Initial -> "initial"
        | Inherit -> "inherit"

    type Selector<'T> =
        | Id of string
        | P5El of P5Element<'T>
        | HTMLEl of HTMLElement

    and P5Element<'T>() =
        [<Emit("$0._pInst")>]
        member private _.p5 = jsNative

        [<Emit("$0.elt")>]
        member _.elt: HTMLElement = jsNative

        [<Emit("$0.id()")>]
        member _.getId() : string = jsNative

        member self.id = self.getId

        [<Emit("$0.id($1)")>]
        member _.setId(id: string) : Unit = jsNative

        [<Emit("$0.class()")>]
        member _.getClass() : string = jsNative

        [<Emit("$0.class($1)")>]
        member _.setClass(clss: string) : Unit = jsNative

        [<Emit("$0.addClass($1)")>]
        member _.addClass(clss: string) = jsNative

        [<Emit("$0.removeClass($1)")>]
        member _.removeClass(clss: string) = jsNative

        [<Emit("$0.hasClass($1)")>]
        member _.hasClass(clss: string) = jsNative

        [<Emit("$0.toggleClass($1)")>]
        member _.toggleClass(clss: string) = jsNative

        /// Returns obj because the p5js child() can return all kind of
        /// things...
        [<Emit("$0.child()")>]
        member _.child() : obj = jsNative

        member self.getChild = self.child

        member self.childBySelector<'a>(s: Selector<'a>) : obj =
            match s with
            | Id i -> emitJsExpr (self, i) "$0.child($1)"
            | P5El e -> emitJsExpr (self, e) "$0.child($1)"
            | HTMLEl e -> emitJsExpr (self, e) "$0.child($1)"

        member self.getChildBySelector = self.childBySelector

        [<Emit("$0.html()")>]
        member _.html() : string = jsNative

        member self.getHtml = self.html

        [<Emit("$0.html($1)")>]
        member _.setHtml(html: string) : Unit = jsNative

        [<Emit("$0.html($1, true)")>]
        member _.appendHtml(html: string) : Unit = jsNative

        member self.mousePressed(fn: P5 -> MouseEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: MouseEvent) -> fn self.p5 e)) "$0.mousePressed($1)"

        [<Emit("$0.mousePressed(false)")>]
        member _.clearMousePressed() = jsNative

        member self.doubleClicked(fn: P5 -> MouseEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: MouseEvent) -> fn self.p5 e)) "$0.doubleClicked($1)"

        [<Emit("$0.doubleClicked(false)")>]
        member _.clearDoubleClicked() = jsNative

        member self.mouseWheel(fn: P5 -> WheelEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: WheelEvent) -> fn self.p5 e)) "$0.mouseWheel($1)"

        [<Emit("$0.mouseWheel(false)")>]
        member _.clearMouseWheel() = jsNative

        member self.mouseReleased(fn: P5 -> MouseEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: MouseEvent) -> fn self.p5 e)) "$0.mouseReleased($1)"

        [<Emit("$0.mouseReleased(false)")>]
        member _.clearMouseReleased() = jsNative

        member self.mouseClicked(fn: P5 -> MouseEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: MouseEvent) -> fn self.p5 e)) "$0.mouseClicked($1)"

        [<Emit("$0.mouseClicked(false)")>]
        member _.clearMouseClicked() = jsNative

        member self.mouseMoved(fn: P5 -> MouseEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: MouseEvent) -> fn self.p5 e)) "$0.mouseMoved($1)"

        [<Emit("$0.mouseMoved(false)")>]
        member _.clearMouseMoved() = jsNative

        member self.mouseOver(fn: P5 -> MouseEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: MouseEvent) -> fn self.p5 e)) "$0.mouseOver($1)"

        [<Emit("$0.mouseOver(false)")>]
        member _.clearMouseOver() = jsNative

        member self.mouseOut(fn: P5 -> MouseEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: MouseEvent) -> fn self.p5 e)) "$0.mouseOut($1)"

        [<Emit("$0.mouseOut(false)")>]
        member _.clearMouseOut() = jsNative

        member self.touchMoved(fn: P5 -> TouchEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: TouchEvent) -> fn self.p5 e)) "$0.touchMoved($1)"

        [<Emit("$0.touchMoved(false)")>]
        member _.clearTouchMoved() = jsNative

        member self.touchStarted(fn: P5 -> TouchEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: TouchEvent) -> fn self.p5 e)) "$0.touchStarted($1)"

        [<Emit("$0.touchStarted(false)")>]
        member _.clearTouchStarted() = jsNative

        member self.touchEnded(fn: P5 -> TouchEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: TouchEvent) -> fn self.p5 e)) "$0.touchEnded($1)"

        [<Emit("$0.touchEnded(false)")>]
        member _.clearTouchEnded() = jsNative

        member self.dragOver(fn: P5 -> DragEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: DragEvent) -> fn self.p5 e)) "$0.dragOver($1)"

        [<Emit("$0.dragOver(false)")>]
        member _.clearDragOver() = jsNative

        member self.dragLeave(fn: P5 -> DragEvent -> Unit) : Unit =
            emitJsExpr (self, (fun (e: DragEvent) -> fn self.p5 e)) "$0.dragLeave($1)"

        [<Emit("$0.dragLeave(false)")>]
        member _.clearDragLeave() = jsNative

        [<Emit("$0.drop($1)")>]
        member _.drop(callback: File -> Unit) : Unit = jsNative

        [<Emit("$0.drop($1, $2)")>]
        member _.dropWithCallback (callback: File -> Unit) (fxn: Unit -> Unit) : Unit = jsNative

        [<Emit("$0.center()")>]
        member _.center() : Unit = jsNative

        [<Emit("$0.center($1)")>]
        member _.centerWithAlign(align: string) : Unit = jsNative

        [<Emit("$0.size()")>]
        member _.size() : Dimensions = jsNative

        member self.getSize = self.size

        [<Emit("$0.size($1, $2)")>]
        member _.setSize (w: float) (h: float) = jsNative

        [<Emit("$0.size($1)")>]
        member _.setWidth(w: float) = jsNative

        [<Emit("$0.style($1, $2)")>]
        member _.style (property: string) (value: string) : Unit = jsNative

        member self.setStyle = self.style

        [<Emit("$0.style($1)")>]
        member _.getStyle(property: string) : string = jsNative

        [<Emit("$0.attribute($1, $2)")>]
        member _.attribute (attr: string) (value: string) : Unit = jsNative

        member self.setAttribute = self.attribute

        [<Emit("$0.attribute($1)")>]
        member _.getAttribute(attr: string) : string = jsNative

        [<Emit("$0.removeAttribute($1)")>]
        member _.removeAttribute(attr: string) : Unit = jsNative

        [<Emit("$0.position()")>]
        member _.getPosition: Position = jsNative

        [<Emit("$0.position($1, $2, $3)")>]
        member private _.setPosition_ (x: float) (y: float) (positionType: string) : Unit = jsNative

        [<Emit("$0.position($1, $2)")>]
        member _.setPosition (x: float) (y: float) : Unit = jsNative

        member this.setPositionWithType (x: float) (y: float) (positionType: PositionType) : Unit =
            this.setPosition_ x y (rawPositionType positionType)

        [<Emit("$0.value()")>]
        member _.getValue() : 'T = jsNative

        [<Emit("$0.value($1)")>]
        member _.setValue(value: 'T) : Unit = jsNative

        [<Emit("$0.parent()")>]
        member _.getParent() : P5Element<'U> = jsNative

        member self.getParentBySelector(selector: Selector<'U>) : P5Element<'U> =
            let jsExpr = "$0.parent($1)"

            match selector with
            | Id id -> emitJsExpr (self, id) jsExpr
            | P5El el -> emitJsExpr (self, el) jsExpr
            | HTMLEl el -> emitJsExpr (self, el) jsExpr

        [<Emit("$0.parent($1)")>]
        member _.setParentFromSelector(parent: string) : Unit = jsNative

        [<Emit("$0.parent($1)")>]
        member _.setParentFromNode(parent: Element) : Unit = jsNative

        [<Emit("$0.parent($1)")>]
        member _.setParent(parent: P5Element<obj>) : Unit = jsNative

        [<Emit("$0.changed($1)")>]
        member _.changed(f: Event -> Unit) : Unit = jsNative

        [<Emit("$0.input($1)")>]
        member _.input(f: Event -> Unit) : Unit = jsNative

        [<Emit("$0.clearInput()")>]
        member _.clearInput() : Unit = jsNative

        [<Emit("$0.changed(false)")>]
        member _.clearChanged() : Unit = jsNative

        [<Emit("$0.checked()")>]
        member _.isChecked() : bool = jsNative

        [<Emit("$0.remove()")>]
        member _.remove() : Unit = jsNative

        [<Emit("$0.show()")>]
        member _.show() : Unit = jsNative

        [<Emit("$0.hide()")>]
        member _.hide() : Unit = jsNative

    type P5SelectAble() =
        inherit P5Element<string>()

        [<Emit("$0.option($1)")>]
        member _.option(value: string) : Unit = jsNative


        [<Emit("$0.option($1, $2)")>]
        member _.optionWithLabel (value: string) (label: string) : Unit = jsNative

        [<Emit("$0.disable($1)")>]
        member _.disable(value: string) : Unit = jsNative


        [<Emit("$0.selected($1)")>]
        member _.selected(value: string) : Unit = jsNative

    type P5Select() =
        inherit P5SelectAble()

    type P5Radio() =
        inherit P5SelectAble()

    type P5ColorPicker() =
        inherit P5Element<string>()

        [<Emit("$0.color()")>]
        member private _._color() : P5Color = jsNative

        member self.color() : Color = self._color () |> P5Color

        member self.getColor = self.color

    type P5MediaElement() =
        inherit P5Element<Unit>()
        interface IImage

        [<Emit("$0.loop()")>]
        member _.loop() : Unit = jsNative

    [<Emit("$0.select($1)")>]
    let select (p5: P5) (selector: string) : P5Element<'U> option = jsNative

    let selectIn (p5: P5) (selector: string) (container: Selector<'U>) : P5Element<'U> option =
        let jsExpr = "$0.select($1, $2)"

        match container with
        | Id id -> emitJsExpr (p5, selector, id) jsExpr
        | P5El el -> emitJsExpr (p5, selector, el) jsExpr
        | HTMLEl el -> emitJsExpr (p5, selector, el) jsExpr


    [<Emit("$0.selectAll($1)")>]
    let selectAll (p5: P5) (selector: string) : P5Element<'U> array = jsNative

    let selectAllIn (p5: P5) (selector: string) (container: Selector<'U>) : P5Element<'U> array =
        let jsExpr = "$0.selectAll($1, $2)"

        match container with
        | Id id -> emitJsExpr (p5, selector, id) jsExpr
        | P5El el -> emitJsExpr (p5, selector, el) jsExpr
        | HTMLEl el -> emitJsExpr (p5, selector, el) jsExpr

    [<Emit("$0.removeElements()")>]
    let removeElements (p5: P5) : Unit = jsNative

    [<Emit("$0.createDiv($1)")>]
    let createDiv (p5: P5) (innerHTML: string) : P5Element<Unit> = jsNative

    [<Emit("$0.createP($1)")>]
    let createP (p5: P5) (innerHTML: string) : P5Element<Unit> = jsNative

    [<Emit("$0.createSpan($1)")>]
    let createSpan (p5: P5) (innerHTML: string) : P5Element<Unit> = jsNative

    [<Emit("$0.createSelect()")>]
    let createSelect (p5: P5) : P5Select = jsNative

    [<Emit("$0.createSelect(true)")>]
    let createMultipleSelect (p5: P5) : P5Select = jsNative

    [<Emit("$0createSelect($1)")>]
    let createSelectFromExisting (p5: P5) (existing: Element) : P5Select = jsNative

    [<Emit("$0.createRadio()")>]
    let createRadio (p5: P5) : P5Radio = jsNative

    [<Emit("$0.createRadio($1)")>]
    let createRadioWithName (p5: P5) (name: string) : P5Radio = jsNative

    [<Emit("$0.createRadio($1)")>]
    let createRadioFromContainer (p5: P5) (container: Element) : P5Radio = jsNative

    [<Emit("$0.createRadio($1, $2)")>]
    let createRadioFromContainerWithName (p5: P5) (container: Element) (name: string) : P5Radio = jsNative

    [<Emit("$0.createColorPicker()")>]
    let createColorPicker (p5: P5) : P5ColorPicker = jsNative

    let createColorPickerWithValue (p5: P5) (color: Color) : P5ColorPicker =
        let c = ensureP5Color p5 color

        emitJsExpr (p5, c) "$0.createColorPicker($1)"

    [<Emit("$0.createInput()")>]
    let createInput (p5: P5) : P5Element<string> = jsNative

    [<Emit("$0.createImg($1, $2)")>]
    let createImg (p5: P5) (src: string) (alt: string) : P5Element<Unit> = jsNative

    [<Emit("$0.createImg($1, $2, $3)")>]
    let createImgWithCors (p5: P5) (src: string) (alt: string) (cors: string) : P5Element<Unit> = jsNative

    [<Emit("$0.createImg($1, $2, $3, $4)")>]
    let createImgWithCallback
        (p5: P5)
        (src: string)
        (alt: string)
        (cors: string)
        (successCallback: P5Element<Unit> -> Unit)
        : P5Element<Unit> =
        jsNative

    [<Emit("$0.createA($1, $2)")>]
    let createA (p5: P5) (href: string) (html: string) : P5Element<Unit> = jsNative

    [<Emit("$0.createA($1, $2, $3)")>]
    let createAWithTarget (p5: P5) (href: string) (html: string) (target: string) : P5Element<Unit> = jsNative

    [<Emit("$0.createInput($1)")>]
    let createInputWithValue (p5: P5) (value: string) : P5Element<string> = jsNative

    [<Emit("$0.createInput($1, $2)")>]
    let createInputWithValueAndType (p5: P5) (value: string) (inputType: string) : P5Element<string> = jsNative

    [<Emit("$0.createSlider($1, $2)")>]
    let createSlider (p5: P5) (min: float) (max: float) : P5Element<float> = jsNative

    [<Emit("$0.createSlider($1, $2, $3, $4)")>]
    let createSliderWithOptions (p5: P5) (min: float) (max: float) (value: float) (step: float) : P5Element<float> =
        jsNative

    [<Emit("$0.createButton($1)")>]
    let createButton (p5: P5) (label: string) : P5Element<string> = jsNative

    [<Emit("$0.createButton($1, $2)")>]
    let createButtonWithValue (p5: P5) (label: string) (value: string) : P5Element<string> = jsNative

    [<Emit("$0.createCheckbox($1)")>]
    let createCheckboxWithLabel (p5: P5) (label: string) : P5Element<bool> = jsNative

    [<Emit("$0.createCheckbox($1, $2)")>]
    let createCheckboxWithLabelAndValue (p5: P5) (label: string) (value: bool) : P5Element<bool> = jsNative

    /// TODO: with callback
    [<Emit("$0.createVideo($1)")>]
    let createVideo (p5: P5) (src: string) : P5MediaElement = jsNative
