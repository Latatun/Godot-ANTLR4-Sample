extends Label

func _on_control_on_text_parsed(result: String):
	print("What did I receive...?", result)
	text += result + "\n"
