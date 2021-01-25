# Primary Table: Overall Fishing Trip Summary
-	Summary of the trip
-	Primary key will be a username that the user will make

### Example Primary Table
| Username | Date | Time Start | Type of Fishing | Location | Total # of Fish | Hours Spent Fishing | Moon Phase | Season | AVG Temp |
|----------|------|------------|-----------------|----------|-----------------|---------------------|------------|--------|----------|
|joeslee | 20JAN21 | 1200 | Bait Fishing | Monument Lake | 8 | 5 | WXC | Winter | 32F / 0C |

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
  - Moon phase as it affects the tide
    - Automatically inputted by the system by creating a recursive loop
      - New moon (NM)
      - Waxing crescent (WXC), First quarter (1Q), Waxing gibbous (WXG)
      - Full moon (FM)
      - Waning gibbous (WAG), Third quarter (3Q), Waning crescent (WAC)
  - Season of fishing
    - Dropdown menu: Winter (Win), Spring (Spr), Summer (Sum), Fall (Fal)
  - Avg Temp of Trip
    - Either in freedom units or Celsius

---

# Secondary Table: Types of Fish Caught
-	A more specific look at the fish that were caught during the trip
-	Primary key will be a composite of fish # and type of fish
-	Username and location will be foreign keys

### Example Secondary Table
| Fish # | Type of Fish | Type of Bait/Lure Used | Color of Lure Used | Rod Used | Time Caught | Weight of fish (lbs) | Length of Fish (in) | Picture | Username | Location |
|--------|--------------|------------------------|--------------------|----------|-------------|----------------------|---------------------|---------|----------|----------|
| 1 | Rainbow Trout | Mealworm | Gold | Cabela’s       | 1205 | 1.1 | 10  | N/A | joeslee | Monument Lake |
| 2 | Rainbow Trout | Mealworm | Gold | Cabela’s       | 1300 | 1   | 9   | N/A | joeslee | Monument Lake |
| 3 | Rainbow Trout | Mealworm | Gold | Cabela’s       | 1306 | N/A | N/A | N/A | joeslee | Monument Lake |
| 4 | Rainbow Trout | Waxworm  | Gold | Cabela’s       | 1340 | 2   | 12  | N/A | joeslee | Monument Lake |
| 5 | Rainbow Trout | Waxworm  | Gold | Cabela’s       | 1455 | 2.1 | 11  | N/A | joeslee | Monument Lake |
| 6 | Rainbow Trout | Waxworm  | Pink | Cabela’s       | 1600 | N/A | N/A | N/A | joeslee | Monument Lake |
| 7 | Rainbow Trout | Waxworm  | Lime Green | Cabela’s | 1605 | N/A | 9.5 | N/A | joeslee | Monument Lake |
| 8 | Rainbow Trout | Waxworm  | Neon Pink | Cabela’s  | 1633 | 1   | 9   | N/A | joeslee | Monument Lake |

### Secondary Table Description
2. Information that helps identify more specifically the fish caught during the trip
- Type of Bait/Lure Used
  - Allow the user to enter in a string char limit of 50
- Color of Lure Used
  - If a lure was used, what color was it
- Rod Used
  - Allow use to enter in a string char limit of 50
- Time caught
  - 24-hour format 0000-2359
- Weight of fish
  - Measured in lbs
  - Decimal value up to 2 decimal points
- Length of fish
  - Measured in in
  - Decimal value up to 2 decimal points
- Foreign keys
  - Username and Location

---

# Tertiary Table: Bites and Catches
-	Summary of the bites and from those bites how many were caught
-	Also shows how much (of which) bait was used so that the user can prepare for the next trip

### Example Tertiary Table
| Date of Trip | Number of Bites | Total number of Fish Caught | Total number of bait used | Overall Comments | Username | Location |
|--------------|-----------------|-----------------------------|---------------------------|------------------|----------|----------|
| 20JAN21 | 20 | 8 | 30 | Extremely cold on the lake due to the wind chill. Bring shelter for next trip. | joeslee | Monument Lake |

### Tertiary Table Description
3. Information that gives the user information for the next trip
-	Number of bites that they got
-	Number of fish caught
-	Total number of bait used
-	Overall comments: Limit the comments to 1000 chars.
- Foreign keys
  - Username and Location

---

# Quaternary Table: Biggest Catch
-	Shows the biggest fish that the user caught during that trip

### Example Quaternary Table
| Date of Trip | Weight of Heaviest Fish | Length of Longest Fish | Standard for Master Angler (Weight) | Standard for Master Angler (Length) | Username | Location |
|--------------|-------------------------|------------------------|-------------------------------------|-------------------------------------|----------|----------|
| 20JAN21 | 2.1 | 11 | N/A | 24 | joeslee | Monument Lake |

### Quaternary Table Description
4. Information that informs the user if a fish they caught that day met master angler standards for Colorado
- https://www.fishexplorer.com/masterangler.asp
- Foreign keys
  - Username and Location
