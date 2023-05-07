using System;
namespace _01.Clock
{
	public class Clock
	{
        private const double TOTAL_CIRCLE_ANGLE = 360.00;
		private const double HOURS_IN_A_CLOCK = 12;
		private const double MINUTES_IN_A_CLOCK = 60;
		/**
		 * If set to true add the offset of hour hands to input hour
		 * ex:	input - 12:30
		 *		offset is 50%
		 */
		private const bool USE_ACCURATE_HOUR_OFFSET = true;
		private int hour, minute;

		public Clock(int hour, int minute)
		{
			this.hour = hour;
			this.minute = minute;
		}

        private double getHourHandOffset()
        {
            double degreesPerHour = TOTAL_CIRCLE_ANGLE / HOURS_IN_A_CLOCK;
            double totalHourOffset = degreesPerHour * this.hour;
            if (USE_ACCURATE_HOUR_OFFSET)
            {
                // Add accurate offset of hour hand
                double hourTickOffset = this.minute / MINUTES_IN_A_CLOCK;
                totalHourOffset += (degreesPerHour * hourTickOffset);
            }
            return totalHourOffset;
        }

        private double getMinuteHandOffset()
        {
            // Compute for degreesPerHands
            double degreesPerMinute = TOTAL_CIRCLE_ANGLE / MINUTES_IN_A_CLOCK;
            return degreesPerMinute * this.minute;
        }

        public double Calculate
        {
            get
            {
                // Compute for total hour angle from zero
                double totalHourAngle = getHourHandOffset();

                // Compute for total minute angle from zero
                double totalMinuteAngle = getMinuteHandOffset();

                // Compute for angle distance between hands
                double handsAngleDifference = Math.Abs(totalHourAngle - totalMinuteAngle);

                // Return lesser angle
                if (handsAngleDifference < TOTAL_CIRCLE_ANGLE - handsAngleDifference)
                {
                    return handsAngleDifference;
                }
                return TOTAL_CIRCLE_ANGLE - handsAngleDifference;
            }
        }
    }
}

