using System;
using MonoTouch.UIKit;

namespace TextFieldOrderExample
{
    public static class TextFieldOrderExtension
    {
        public static void SetupFieldOrder(this UIViewController viewController, UITextField[] textFields, Action finalAction = null)
        {
            if (textFields == null)
            {
                throw new ArgumentNullException("textFields");
            }

            for (int i = 0; i < textFields.Length; i++)
            {
                var currentField = textFields[i];
                bool isLastField = (i == textFields.Length - 1);

                if (isLastField && finalAction != null)
                {
                    SetupFinalField(currentField, finalAction);
                }
                else
                {
                    var nextField = isLastField ? textFields[0] : textFields[i + 1];
                    SetupNextField(currentField, nextField);
                }
            }
        }

        private static void SetupNextField(UITextField textField, UITextField nextField)
        {
            textField.ReturnKeyType = UIReturnKeyType.Next;

            textField.ShouldReturn = (tf) =>
            {
                nextField.BecomeFirstResponder();
                return true;
            };
        }

        private static void SetupFinalField(UITextField textField, Action finalAction)
        {
            textField.ReturnKeyType = UIReturnKeyType.Done;

            textField.ShouldReturn = (tf) =>
            {
                tf.ResignFirstResponder();
                finalAction();
                return true;
            };
        }
    }
}


