namespace P5

module Core =

    open System
    open Fable.Core
    open Fable.Core.JsInterop
    open Browser.Dom
    open Browser.Types

    type IImage =
        interface
        end

    /// The methods on this class are for internal use only. You pass an
    /// instance to all functions, but never call a method on it.
    [<ImportAll("p5")>]
    type P5(sketch: Func<obj, Unit>, ?node: Browser.Types.Element) =
        interface IImage

        /// TODO: check for a way to test this.
        member _.disableFriendlyErrors
            with get (): bool = jsNative
            and set (_: bool): Unit = jsNative

        member _.preload
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.setup
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.draw
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        [<Emit("$0.reset()")>]
        member _.reset() : Unit = jsNative

        [<Emit("$0.remove()")>]
        member _.remove() : Unit = jsNative

    type EventHandler<'e, 'a> =
        | Effect of (P5 -> 'e -> Unit)
        | Update of (P5 -> 'e -> 'a -> 'a)

    type Subscription<'a> =
        | OnDeviceTurned of EventHandler<Unit, 'a>
        | OnDeviceMoved of EventHandler<Unit, 'a>
        | OnDeviceShaken of EventHandler<Unit, 'a>
        | OnKeyPressed of EventHandler<KeyboardEvent, 'a>
        | OnKeyReleased of EventHandler<KeyboardEvent, 'a>
        | OnKeyTyped of EventHandler<KeyboardEvent, 'a>
        | OnMouseMoved of EventHandler<MouseEvent, 'a>
        | OnMousePressed of EventHandler<MouseEvent, 'a>
        | OnMouseReleased of EventHandler<MouseEvent, 'a>
        | OnMouseClicked of EventHandler<MouseEvent, 'a>
        | OnWindowResized of EventHandler<UIEvent, 'a>
        | PreventDefault of Subscription<'a>

    type private PreventDefault =
        | DoPreventDefault
        | DontPreventDefault

    /// There is no way to do this dynamically, as fas as I am aware.
    let private getDeviceTurnedHandler subscription =
        match subscription with
        | OnDeviceTurned handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnDeviceTurned handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getDeviceMovedHandler subscription =
        match subscription with
        | OnDeviceMoved handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnDeviceMoved handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getDeviceShakenHandler subscription =
        match subscription with
        | OnDeviceShaken handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnDeviceShaken handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getKeyPressedHandler subscription =
        match subscription with
        | OnKeyPressed handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnKeyPressed handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getKeyReleasedHandler subscription =
        match subscription with
        | OnKeyReleased handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnKeyReleased handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getKeyTypedHandler subscription =
        match subscription with
        | OnKeyTyped handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnKeyTyped handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getMouseMovedHandler subscription =
        match subscription with
        | OnMouseMoved handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnMouseMoved handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getMousePressedHandler subscription =
        match subscription with
        | OnMousePressed handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnMousePressed handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getMouseReleasedHandler subscription =
        match subscription with
        | OnMouseReleased handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnMouseReleased handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getMouseClickedHandler subscription =
        match subscription with
        | OnMouseClicked handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnMouseClicked handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    let private getWindowResizedHandler subscription =
        match subscription with
        | OnWindowResized handler -> Some(DontPreventDefault, handler)
        | PreventDefault(OnWindowResized handler) -> Some(DoPreventDefault, handler)
        | _ -> None

    type Node =
        | Selector of string
        | Element of Browser.Types.Element
        | NoNode

    type Init<'preloadState, 'state> =
        | Setup of setup: (P5 -> 'state)
        | PreloadAndSetup of preload: (P5 -> 'preloadState) * setup: (P5 -> 'preloadState -> 'state)

    type Sketch<'preloadState, 'state> =
        { init: Init<'preloadState, 'state>
          update: P5 -> 'state -> 'state
          draw: P5 -> 'state -> Unit
          subscriptions: Subscription<'state> list
          node: Node }

    /// Disables the draw function from being called continuously. This should
    /// belong in P5.Structure, but because we need this in `display`, we would
    /// run into dependency issues.
    [<Emit("$0.noLoop()")>]
    let noLoop (p5: P5) : Unit = jsNative

    /// Returns the time in milliseconds since the start of the sketch. This
    /// should belong in P5.Time, but because we need this in `animate`, we
    /// would run into dependency issues.
    [<Emit("$0.millis()")>]
    let millis (p5: P5) : int = jsNative

    let defaultSketch setup =
        { init = Setup setup
          update = (fun _ -> id)
          draw = (fun _ _ -> ())
          subscriptions = []
          node = NoNode }

    let defaultPreloadSketch preload setup =
        { init = PreloadAndSetup(preload, setup)
          update = (fun _ -> id)
          draw = (fun _ _ -> ())
          subscriptions = []
          node = NoNode }

    [<Global>]
    let console: JS.Console = jsNative

    let createSketch (sketch: Sketch<'preloadState, 'state>) : Unit =
        let nodeElement =
            match sketch.node with
            | Selector selector -> document.querySelector (selector)
            | Element element -> element
            | NoNode -> null

        let p5Sketch =
            // Inspired by https://github.com/aolney/fable-p5-demo
            new Func<obj, unit>(fun boxedP5 ->
                let mutable state = Unchecked.defaultof<'state>
                let p5 = unbox<P5> boxedP5

                // For testing purposes, delete this later.
                console.log p5

                match sketch.init with
                | PreloadAndSetup(preload, setup) ->
                    let mutable preloadState = Unchecked.defaultof<'preloadState>
                    p5.preload <- fun () -> preloadState <- preload p5
                    p5.setup <- fun () -> state <- setup p5 preloadState
                | Setup setup -> p5.setup <- fun () -> state <- setup p5

                p5.draw <-
                    fun () ->
                        state <- sketch.update p5 state
                        sketch.draw p5 state

                let executeHandler ev handler =
                    match handler with
                    | (Effect f) -> f p5 ev
                    | (Update f) -> state <- f p5 ev state

                let setEventProperty property handlerFilter =
                    match List.choose handlerFilter sketch.subscriptions with
                    | [] -> ()
                    | handlersAndConfig ->
                        p5?(property) <-
                            fun ev ->
                                // Execute the handlers in order.
                                handlersAndConfig |> List.map snd |> List.iter (executeHandler ev)

                                // If any of them indicate to preventDefault,
                                // return false
                                handlersAndConfig |> List.map fst |> List.contains DoPreventDefault |> not

                // We lose some type safety here, but save a lot of typing.
                setEventProperty "deviceTurned" getDeviceTurnedHandler
                setEventProperty "deviceMoved" getDeviceMovedHandler
                setEventProperty "deviceShaken" getDeviceShakenHandler
                setEventProperty "keyPressed" getKeyPressedHandler
                setEventProperty "keyReleased" getKeyReleasedHandler
                setEventProperty "keyTyped" getKeyTypedHandler
                setEventProperty "mouseMoved" getMouseMovedHandler
                setEventProperty "mousePressed" getMousePressedHandler
                setEventProperty "mouseReleased" getMouseReleasedHandler
                setEventProperty "mouseClicked" getMouseClickedHandler
                setEventProperty "windowResized" getWindowResizedHandler)

        new P5(p5Sketch, nodeElement) |> ignore

    let noSetup (_: P5) = ()

    let noUpdate (_: P5) = id

    /// Create a static sketch.
    let display (node: Node) (draw: P5 -> Unit) : Unit =
        let setupWithLoopDisabled (p5: P5) =
            noLoop p5
            ()

        let drawDropState (p5: P5) _ = draw p5

        createSketch
            { defaultSketch setupWithLoopDisabled with
                draw = drawDropState
                node = node }

    let displayWithPreload (node: Node) (preload: P5 -> 'a) (draw: P5 -> 'a -> Unit) : Unit =
        let setupWithLoopDisabled (p5: P5) preloadState =
            noLoop p5
            preloadState

        createSketch
            { defaultPreloadSketch preload setupWithLoopDisabled with
                draw = draw
                node = node }

    /// Create a simple animation sketch, which draws something based on the
    /// time elapsed.
    let animate (node: Node) (setup: P5 -> Unit) (draw: P5 -> int -> Unit) : Unit =
        let setupWithoutState p5 =
            setup p5
            ()

        let drawWithTimeElapsed (p5: P5) _ = draw p5 (millis p5)

        createSketch
            { defaultSketch setupWithoutState with
                draw = drawWithTimeElapsed
                node = node }

    /// Create a simulation sketch. It starts with an initial state, which gets
    /// updated every step.
    let simulate (node: Node) (setup: P5 -> 'a) (update: P5 -> 'a -> 'a) (draw: P5 -> 'a -> Unit) : Unit =
        createSketch
            { defaultSketch setup with
                update = update
                draw = draw
                node = node }

    let simulateWithPreload
        (node: Node)
        (preload: P5 -> 'a)
        (setup: P5 -> 'a -> 'b)
        (update: P5 -> 'b -> 'b)
        (draw: P5 -> 'b -> Unit)
        : Unit =
        createSketch
            { defaultPreloadSketch preload setup with
                update = update
                draw = draw
                node = node }

    /// Create a sketch with all functionality: handling state and events.
    let play
        (node: Node)
        (setup: P5 -> 'a)
        (update: P5 -> 'a -> 'a)
        (draw: P5 -> 'a -> Unit)
        (subscriptions: Subscription<'a> list)
        : Unit =
        createSketch
            { init = Setup setup
              update = update
              draw = draw
              subscriptions = subscriptions
              node = node }

    let playWithPreload
        (node: Node)
        (preload: P5 -> 'a)
        (setup: P5 -> 'a -> 'b)
        (update: P5 -> 'b -> 'b)
        (draw: P5 -> 'b -> Unit)
        (subscriptions: Subscription<'b> list)
        : Unit =
        createSketch
            { init = PreloadAndSetup(preload, setup)
              update = update
              draw = draw
              subscriptions = subscriptions
              node = node }
