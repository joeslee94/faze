# Primary Table: Overall Fishing Trip Summary
-	Summary of the trip
-	Primary key will be a username that the user will make
### Example Primary Table
Username | Date | Time Start | Type of Fishing | Location | Total # of Fish | Hours Spent Fishing | Moon Phase | Season | AVG Temp |
---------|------|------------|-----------------|----------|-----------------|---------------------|------------|--------|----------|
joeslee  |20JAN21|    1200   |  Bait Fishing	 |Monument Lake|      8       |          5          | WXC        | Winter | 32F / 0C |

### Primary Table Description
1. Key information that must be entered in:
- Username
  - Alphanumerical values capped at 20 characters
- Date of fishing trip
  - Day Month Year Format: 20JAN21
- Time started fishing
  - 24-hour format: 0000-2359
- Type of fishing
  - Drop down menu: bait, fly, bait casting, spinning, trolling
- Location of where they fished
  - Longitude or latitude OR
  - General area such as Monument Lake
- Total # of fish caught
  - This will be an integer value greater or equal to 0
- Hours spent fishing
  - This will be an approximate value that is expressed as a decimal
    - 1 = 1 hour
    - 0.75 = 45 min
    - 0.5 = 30 min
    - 0.25 = 15 min
    - 0 = 0 min
o	Moon phase as it affects the tide
	Automatically inputted by the system by creating a recursive loop
•	New moon (NM)
•	Waxing crescent (WXC)
•	First quarter (1Q)
•	Waxing gibbous (WXG)
•	Full moon (FM)
•	Waning gibbous (WAG)
•	Third quarter (3Q)
•	Waning crescent (WAC)
o	Season of fishing
	Dropdown menu
•	Winter (Win)
•	Spring (Spr)
•	Summer (Sum)
•	Fall (Fal)
o	Avg Temp of Trip
	Either in freedom units or Celsius
	Most likely Celsius
