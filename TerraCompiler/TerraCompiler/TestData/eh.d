define MyNewControlThatDoesSomething {
	background: 0x00FF00
	width: 200
	height: 500
}

define MyButton as Button {
	if (state == pressed)
	{
		background: 0x00FF00
	}
	else
	{
		background: 0xFF00FF
	}

	text: "This is a button"

	if (Window.width > 500)
	{
		width: 100
		height: 50
	}
	else
	{
		width: 50
		height: 25
	}
}

Frame {
	id: "UIOrigin"

	MyNewControlThatDoesSomething {
		Button {
			id: "btnbtnbtn"

			anchors: [
				AnchorPoint {
					point: center
					relativeTo: "UIOrigin"
					relativePoint: center
					x: 0
					y: 0
				}
			]

			width: 100
			height: 50
		}
	}

	MyButton {
		anchors: [
			AnchorPoint {
				point: topleft
				relativeTo: parent
				relativePoint: topleft
				x: 50
				y: 75
			}
			AnchorPoint {
				point: bottomright
				relativeTo: "btnbtnbtn"
				relativePoint: topleft
				x: -100
				y: -150
			}
		]
	}
}

