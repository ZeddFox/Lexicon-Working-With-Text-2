1. Purpose
Further train string and array methods.

2. Exercises
  1.  Make a method that takes a text string as a parameter. The text is assumed
  to be many sentences in one large paragraph. The method should split the
  text into several paragraphs by introducing line breaks in the string. You
  get a line break by adding this string value – “\n” – that is a backslash and
  and an n. Return the resulting string.
  Follow the rule that a paragraph should contain one sentence as a
  minimum and any additional sentences as long as the length of the
  paragraph doesn’t exceed 400 characters.
  Use the string array as an intermediate step to solve the challenge.

  2.  Solve the transfer problem where a ProductBackend method has this data
  in the form of a string array:
  [“Milk”, “Yoghurt”, “Cream”, “Cottage Cheese”]
  The data should be transferred to the ProductPresentation method, which
  will use the same string array in a loop writing to the console. But the
  presentation method only accepts a simple string as parameter. How can
  the transfer be done?
