using System;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;
using RosMessageTypes.Std;
using RosMessageTypes.Actionlib;

namespace RosMessageTypes.NiryoOne
{
    public class JoystickJointsActionGoal : Message
    {
        public const string RosMessageName = "niryo_one_msgs/JoystickJointsActionGoal";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public Header header { get; set; }
        public GoalID goal_id { get; set; }
        public JoystickJointsGoal goal { get; set; }

        public JoystickJointsActionGoal()
        {
            this.header = new Header();
            this.goal_id = new GoalID();
            this.goal = new JoystickJointsGoal();
        }

        public JoystickJointsActionGoal(Header header, GoalID goal_id, JoystickJointsGoal goal)
        {
            this.header = header;
            this.goal_id = goal_id;
            this.goal = goal;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.AddRange(goal_id.SerializationStatements());
            listOfSerializations.AddRange(goal.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            offset = this.goal_id.Deserialize(data, offset);
            offset = this.goal.Deserialize(data, offset);

            return offset;
        }

    }
}
