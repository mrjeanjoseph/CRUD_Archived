namespace StructureRehearsals {
    struct StructAndClassExercises {
        public int x;
        public int y;
    }

    struct ExerciseTwoStruct {
        public static int x = 28;
        public static int y = 52;
    }

    class ExerciseThreeStruct {
        //Employee is to be a structure members
        public struct employee {
            public string empName;
            public BirthDate Date;                
        }

        public struct BirthDate {
            public int Day;
            public int Month;
            public int Year;
        }
    }

    class ExerciseFourNewClass {
        public int x;
        public int y;
    }

    struct ExerciseFourNewStruct {
        public int x;
        public int y;
    }

    class ExerciseFiveNewClass {
        public int classID;
    }

    class ExerciseFiveNewStruct {
        public int structID;
    }

    struct ExerciseSixNewStruct {
        private int someNum;
        public int AnotherNum {
            get { return someNum; }
            set { if (value < 50) someNum = value; }
        }
        public void ExerciseSixMethod() {
            System.Console.WriteLine("The stored value is: {0}", someNum);
        }
    }
}
