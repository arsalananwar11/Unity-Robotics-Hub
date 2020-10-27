using System;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;

namespace RosMessageTypes.NiryoOne
{
    public class ToolAction : Message
    {
        public const string RosMessageName = "niryo_one_msgs/ToolAction";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public ToolActionGoal action_goal { get; set; }
        public ToolActionResult action_result { get; set; }
        public ToolActionFeedback action_feedback { get; set; }

        public ToolAction()
        {
            this.action_goal = new ToolActionGoal();
            this.action_result = new ToolActionResult();
            this.action_feedback = new ToolActionFeedback();
        }

        public ToolAction(ToolActionGoal action_goal, ToolActionResult action_result, ToolActionFeedback action_feedback)
        {
            this.action_goal = action_goal;
            this.action_result = action_result;
            this.action_feedback = action_feedback;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(action_goal.SerializationStatements());
            listOfSerializations.AddRange(action_result.SerializationStatements());
            listOfSerializations.AddRange(action_feedback.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.action_goal.Deserialize(data, offset);
            offset = this.action_result.Deserialize(data, offset);
            offset = this.action_feedback.Deserialize(data, offset);

            return offset;
        }

    }
}
